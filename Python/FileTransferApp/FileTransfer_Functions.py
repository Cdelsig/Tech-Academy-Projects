##Python: V 3.6.1
##
##Author: Carrie Del Signore
##
##Purpose: To practice GUI build for daily file transfer script -- FUNCTIONS
##
##

from tkinter import *
from tkinter import ttk
import tkinter as tk
from tkinter import messagebox
import os.path, time, glob, datetime, shutil, sqlite3

import FileTransferGUI

conn = sqlite3.connect('fileTransfer.db')
c = conn.cursor()  # here is our cursor


def create_table():
    c.execute(
        'CREATE TABLE IF NOT EXISTS tbl_fileCheck(lastChecked TEXT, srcFolder TEXT, destFolder TEXT, movedTF INTEGER)')


create_table()


def selSrc(self):
    srcDir = tk.filedialog.askdirectory()
    xvar = srcDir
    self.entry_src.delete(0, END)
    self.entry_src.insert(0, xvar)
    return xvar


def selDest(self):
    destDir = tk.filedialog.askdirectory()
    yvar = destDir
    self.entry_dest.delete(0, END)
    self.entry_dest.insert(0, yvar)
    return yvar


def make_transfer(self):
    srcVar = self.entry_src.get()
    destVar = self.entry_dest.get()
    folderFiles = glob.iglob(os.path.join(srcVar, "*.*"))
    fileName = list(os.listdir(srcVar))
    transfFiles = []
    i = 0

    # re-purposing from original project to simply transfer files, regardless of time created/modified
    # unix = time.time()
    # date = str(datetime.datetime.fromtimestamp(unix).strftime('%Y-%m-%d %H:%M:%S'))
    moved = 0

    if messagebox.askokcancel("Confirm File Transfer",
                              "Check for files to transfer from: \n\n{} \nto \n{}?".format(srcVar, destVar)):

        while i < len(fileName):
            for files in folderFiles:
                # changing 3/3/2019 to re-purpose application utility. see above
                # fileCreated = os.path.getctime(files)
                # fileModified = os.path.getmtime(files)

                # if (unix - fileCreated) > 86400 and (unix - fileModified) > 86400:
                  # pass
                # if (unix - fileCreated < 86400) or (unix - fileModified < 86400):
                if os.path.isfile(files):
                    shutil.move(files, destVar)
                    transfFiles.append(fileName[i])
                i = i + 1

            if len(transfFiles) > 0:
                moved = 1
                messagebox.showinfo("Transfer Success", "Files successfully transferred!")
            else:
                moved = 0
                messagebox.showinfo("Transfer Info", "No files to transfer today.")

        c.execute('INSERT INTO tbl_fileCheck(lastChecked, srcFolder, destFolder, movedTF) VALUES (?,?,?,?)',
                  (date, srcVar, destVar, moved))
        conn.commit()


def set_dtChecked(self):
    c.execute("SELECT lastChecked FROM tbl_fileCheck ORDER BY lastChecked DESC LIMIT 1")
    self.lastDt = StringVar()
    getDt = c.fetchall()
    self.lastDt.set(getDt)


# c.close()
# conn.close()


if __name__ == "__main__": pass
