##Python: V 3.6.1
##
##Author: Carrie Del Signore
##
##Purpose: To practice GUI build for daily file transfer script
##
##

from tkinter import *
from tkinter import ttk
from tkinter import filedialog
import tkinter as tk
from tkinter import messagebox
import os.path, time, glob, datetime, shutil, sqlite3

import FileTransfer_Functions

conn = sqlite3.connect('fileTransfer.db')
c = conn.cursor()


class FileTransferApp:

    def __init__(self, master):
        FileTransfer_Functions.set_dtChecked(self)

        self.master = master

        # for master window:
        master.title("File Transfer App")
        master.resizable(False, False)

        self.logo = PhotoImage(file='rocket.png')
        ttk.Label(master, image=self.logo).grid(row=0, column=0, rowspan=7, sticky='nw', padx=(5, 0),
                                                pady=(5, 0))  # img

        # wrapping each source/dest in a frame, in order to make bigger
        self.inputFrameSrc = tk.Frame(master, width=250, height=50)
        self.inputFrameSrc.grid(row=1, column=1)
        self.inputFrameSrc.columnconfigure(1, weight=10)  # allow the column inside the entryFrame to grow
        # By default the frame will shrink to whatever is inside of it and
        # ignore width & height. We change that:
        self.inputFrameSrc.grid_propagate(False)

        self.inputFrameDest = tk.Frame(master, width=250, height=50)
        self.inputFrameDest.grid(row=3, column=1)
        self.inputFrameDest.columnconfigure(1, weight=10)  # allow the column inside the entryFrame to grow
        self.inputFrameDest.grid_propagate(False)

        # Labels:
        self.label_title = tk.Label(master, text="FileShuttle Express", font=14)  # title
        self.label_title.grid(row=0, column=0, columnspan=3, padx=(100, 0), pady=(10, 10))

        self.label_selectSrc = tk.Label(self.inputFrameSrc, text="Select source directory:")  # btn labels
        self.label_selectSrc.grid(row=1, column=1, pady=(5, 5), sticky='w')

        self.label_selectDest = tk.Label(self.inputFrameDest, text="Select destination directory:")  # btn labels
        # self.label_selectDest.grid(row=1, column=1, padx=(10,5), pady=(5,5))
        self.label_selectDest.grid(row=3, column=1, pady=(5, 5), sticky='w')

        self.label_lastChecked = tk.Label(master, text="Date last transferred: ")  # last checked:
        self.label_lastChecked.grid(row=6, column=1, padx=(5, 10), pady=(10, 0), sticky='se')

        self.label_dtChecked = tk.Label(master, textvariable=self.lastDt)  # datetime of last checked
        self.label_dtChecked.grid(row=6, column=2, padx=(0, 10), pady=(10, 0), sticky='sw')

        # buttons
        self.btn_selectSrc = tk.Button(master, text="Source", width=12,
                                       command=lambda: FileTransfer_Functions.selSrc(self))
        self.btn_selectSrc.grid(row=1, column=2, padx=(10, 10), pady=(5, 5), sticky='s')

        self.btn_selectDest = tk.Button(master, text="Destination", width=12,
                                        command=lambda: FileTransfer_Functions.selDest(self))
        self.btn_selectDest.grid(row=3, column=2, padx=(10, 10), pady=(5, 5), sticky='s')

        self.btn_run = tk.Button(master, text="Transfer Files", width=20, height=2,
                                 command=lambda: FileTransfer_Functions.make_transfer(self))
        self.btn_run.grid(row=5, column=1, sticky='e', pady=(5, 5))

        # entry boxes- to be filled on click
        self.entry_src = tk.Entry(self.inputFrameSrc)
        self.entry_src.grid(row=2, column=1, padx=(5, 5), pady=(0, 5), sticky='we', columnspan=2)

        self.entry_dest = tk.Entry(self.inputFrameDest)
        self.entry_dest.grid(row=4, column=1, padx=(5, 5), pady=(0, 5), sticky='ew', columnspan=2)


def main():
    root = Tk()
    app = FileTransferApp(root)
    root.mainloop()


if __name__ == "__main__": main()
