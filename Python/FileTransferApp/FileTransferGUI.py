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

        #for master window:
        master.title("File Mover App")
        master.resizable(False, False)

        self.logo = PhotoImage(file= 'rocket.png')

        #Labels:
        self.label_title = tk.Label(master, text = "FileShuttle Express", font=14)#title
        ttk.Label(master, image = self.logo).grid(row = 0, column = 0, sticky='nw', padx=(5,0), pady=(5,0))#img
        self.label_title.grid(row=0, column=0, columnspan=2, pady=(10,10))

        self.label_selectSrc = tk.Label(master, text = "Select source directory:")#btn labels
        self.label_selectSrc.grid(row=1, column=0, padx=(5,5), pady=(5,5), sticky='nw')

        self.label_selectDest = tk.Label(master, text = "Select destination directory:")#btn labels
        self.label_selectDest.grid(row=1, column=1, padx=(10,5), pady=(5,5))

        self.label_lastChecked = tk.Label(master, text = "Last checked: ")#last checked:
        self.label_lastChecked.grid(row=4, column=0, padx=(5,5), pady=(10,0), sticky='sw')
        
        self.label_dtChecked = tk.Label(master, textvariable = self.lastDt)#datetime of last checked
        self.label_dtChecked.grid(row=4, column=1, padx=(5,5), pady=(10,0), sticky='sw')


        #buttons
        self.btn_selectSrc = tk.Button(master, text = "Source", width=12,
                                      command= lambda: FileTransfer_Functions.selSrc(self))
        self.btn_selectSrc.grid(row=2, column=0, sticky='nw', padx=(5,5))

        self.btn_selectDest = tk.Button(master, text = "Destination", width=12,
                                       command= lambda: FileTransfer_Functions.selDest(self))
        self.btn_selectDest.grid(row=2, column=1, sticky='nw', padx=(10,5))

        self.btn_run = tk.Button(master, text = "Check Files for Transfer", width=12, height=2,
                                       command= lambda: FileTransfer_Functions.make_transfer(self))
        self.btn_run.grid(row=5, column=0, columnspan=2, sticky='ew', padx=(5,5), pady=(5,5))

        #entry boxes- to be filled on click
        self.entry_src = tk.Entry(master)
        self.entry_src.grid(row=3, column=0, padx=(5,5), pady=(5,5), sticky='w')

        self.entry_dest = tk.Entry(master)
        self.entry_dest.grid(row=3, column=1, padx=(10,5), pady=(5,5), sticky='w')


            
def main():
    
    root = Tk()
    app = FileTransferApp(root)
    root.mainloop()
    

    
if __name__ == "__main__": main()

