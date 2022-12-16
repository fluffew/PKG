import cv2
import numpy as np
from matplotlib import pyplot as plt
import matplotlib as mp
import sys
from PyQt5.QtCore import *
from PyQt5.QtGui import *
from PyQt5.QtWidgets import *


class ImageProcessing():
    @staticmethod
    def average_blur(infilepath):
        img = cv2.imread(infilepath)
        blur = cv2.blur(img, (5, 5))
        cv2.imshow("Average blur", blur)

    @staticmethod
    def gaussian_blur(infilepath):
        img = cv2.imread(infilepath)
        blur = cv2.GaussianBlur(img, (5, 5), 0)
        cv2.imshow("Gaussian blur", blur)

    @staticmethod
    def median_blur(infilepath):
        img = cv2.imread(infilepath)
        median = cv2.medianBlur(img, 5)
        cv2.imshow("Median blur", median)

    @staticmethod
    def equalization_hist_hsv(infilepath):
        image = cv2.imread(infilepath)
        H, S, V = cv2.split(cv2.cvtColor(image, cv2.COLOR_BGR2HSV))
        eq_V = cv2.equalizeHist(V)
        eq_image = cv2.cvtColor(cv2.merge([H, S, eq_V]), cv2.COLOR_HSV2BGR)
        return eq_image

    @staticmethod
    def equalization_hist_rgb(infilepath):
        image = cv2.imread(infilepath)
        channels = cv2.split(image)
        eq_channels = []
        for ch, color in zip(channels, ['B', 'G', 'R']):
            eq_channels.append(cv2.equalizeHist(ch))
        eq_image = cv2.merge(eq_channels)
        return eq_image

    @staticmethod
    def linear_contrasting_grayscale(infilepath):
        img = cv2.imread(infilepath, cv2.IMREAD_GRAYSCALE)
        norm_img1 = cv2.normalize(
            img, None, alpha=0, beta=1, norm_type=cv2.NORM_MINMAX, dtype=cv2.CV_32F)
    # scale to uint8
        norm_img1 = (255*norm_img1).astype(np.uint8)

    # display input and both output images
        return norm_img1

    @staticmethod
    def equalization_hist_grayscale(infilepath):
        img = cv2.imread(infilepath, 0)
        equ = cv2.equalizeHist(img)
        return equ


class main_window(QWidget):

    def __init__(self, parent=None):
        super(main_window, self).__init__(parent)
        layout = QVBoxLayout()
        self.fname = ""
        self.btnChoose = QPushButton("Choose image...")
        self.btnChoose.clicked.connect(self.getfile)
        self.btnGrayscale = QPushButton(
            "Histogram equalization and linear contrasting")
        self.btnGrayscale.clicked.connect(self.grayscale)
        self.btnColorful = QPushButton(
            "Histogram equalization for RGB and HSV")
        self.btnColorful.clicked.connect(self.colorful)
        self.btnBlur = QPushButton("Smoothing filters")
        self.btnBlur.clicked.connect(self.blur)

        layout.addWidget(self.btnChoose)
        layout.addWidget(self.btnGrayscale)
        layout.addWidget(self.btnColorful)
        layout.addWidget(self.btnBlur)
        self.le = QLabel("Hello", self)
        self.le.setSizePolicy(QSizePolicy.Expanding, QSizePolicy.Expanding)
        self.le.setAlignment(Qt.AlignCenter)
        self.le.setStyleSheet("QLabel {background-color: black;}")

        layout.addWidget(self.le)
        self.setLayout(layout)
        self.setWindowTitle("Image processing")
        self.setGeometry(100, 100, 100, 100)

    def getfile(self):
        self.fname, _ = QFileDialog.getOpenFileName(
            self, 'Open file', 'C:', "Image files (*.jpg *.jpeg *.png *.bmp)")
        pic = QPixmap(self.fname, _)
        self.path = _ + "\\" + self.fname
        if (pic.width() > 1000 or pic.height() > 1000):
            self.showDialog(2)
        else:
            self.le.setPixmap(pic)
            self.resize(pic.width(), pic.height())

    def grayscale(self):
        if self.fname == "":
            self.showDialog(1)
        else:
            pic_hist = ImageProcessing.equalization_hist_grayscale(self.fname)
            pic_linear = ImageProcessing.linear_contrasting_grayscale(self.fname)
            cv2.imshow('Histogram equalization', pic_hist)
            cv2.imshow('Linear contrasting', pic_linear)
            
            plt.subplot(1, 2, 1)
            hist, bins = np.histogram(pic_hist.flatten(), 256, [0, 256])
            cdf = hist.cumsum()
            cdf_normalized = cdf * float(hist.max()) / cdf.max()
            plt.plot(cdf_normalized, color='b')
            plt.hist(pic_hist.flatten(), 256, [0, 256], color='r')
            plt.xlim([0, 256])
            plt.title("Histogram equalization")
            plt.legend(('cdf', 'histogram'), loc='upper left')

            plt.subplot(1, 2, 2)
            hist, bins = np.histogram(pic_linear.flatten(), 256, [0, 256])
            cdf = hist.cumsum()
            cdf_normalized = cdf * float(hist.max()) / cdf.max()
            plt.plot(cdf_normalized, color='b')
            plt.hist(pic_linear.flatten(), 256, [0, 256], color='r')
            plt.xlim([0, 256])
            plt.title("Linear constasting")
            plt.legend(('cdf', 'histogram'), loc='upper left')
            
            plt.show()
            main_window.blockButtons(self, True)
            cv2.waitKey(0)
            plt.close
            main_window.blockButtons(self, False)
            
            cv2.destroyAllWindows()
    def blockButtons(self, is_blocked) :
        self.btnBlur.blockSignals(is_blocked)
        self.btnChoose.blockSignals(is_blocked)
        self.btnColorful.blockSignals(is_blocked)
        self.btnGrayscale.blockSignals(is_blocked)

    def colorful(self):
        if self.fname == "":
            self.showDialog(1)
        else:
            rgb = ImageProcessing.equalization_hist_rgb(self.fname)
            hsv = ImageProcessing.equalization_hist_hsv(self.fname)

            plt.subplot(1, 2, 1)
            channels = ('b', 'g', 'r')
            plt.title("Histogram equalization by RGB")
            for i, color in enumerate(channels):
                histogram = cv2.calcHist([rgb], [i], None, [256], [0, 256])
                plt.plot(histogram, color=color)
            plt.xlim([0, 256])

            plt.subplot(1, 2, 2)
            plt.title("Histogram equalization by HSV")
            for i, color in enumerate(channels):
                histogram = cv2.calcHist([hsv], [i], None, [256], [0, 256])
                plt.plot(histogram, color=color)
            plt.xlim([0, 256])
            plt.show()
            cv2.imshow("Histogram equalization by RGB", rgb)
            cv2.imshow("Histogram equalization by HSV", hsv)
            main_window.blockButtons(self, True)
            cv2.waitKey(0)
            main_window.blockButtons(self, False)
            plt.close()
            cv2.destroyAllWindows()

    def blur(self):
        if self.fname == "":
            self.showDialog(1)
        else:
            ImageProcessing.average_blur(self.fname)
            ImageProcessing.gaussian_blur(self.fname)
            ImageProcessing.median_blur(self.fname)
            main_window.blockButtons(self, True)
            cv2.waitKey(0)
            main_window.blockButtons(self, False)
            cv2.destroyAllWindows()

    def showDialog(self, id):
        msgBox = QMessageBox()
        msgBox.setIcon(QMessageBox.Warning)
        if id == 1 :
            msgBox.setText("No image to process")
            msgBox.setWindowTitle("Warning")
        elif id == 2:
            msgBox.setText("Max image size is (1000, 1000)")
            msgBox.setWindowTitle("Warning")

        rar = msgBox.exec()


def main():
    app = QApplication(sys.argv)
    ex = main_window()
    ex.show()
    sys.exit(app.exec_())


if __name__ == '__main__':
    main()
