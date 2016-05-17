# XlsAutoFit
Tool to auto fit columns in all sheets of an excel file

Setup:
	1. Download and install Python 2.7.11:
		 https://www.python.org/ftp/python/2.7.11/python-2.7.11.msi
	   Click on link to download msi. Double click it to install.
	   Make sure python is installed on C:\Python27 folder on your system.
	   C:\Python27 should also show up in Path environment variable on your system.

	2. Download and install pywin 32 python library:
		 https://sourceforge.net/projects/pywin32/files/pywin32/Build%20220/pywin32-220.win32-py2.7.exe/download
		 Click on link to download msi. Double click it to install.
	   Library will get installed at C:\Python27\Lib\site-packages on your system.
	   You should see some new folders (like win32, win32com etc) and files created in the above location which indicates library installed successfully.
   
  
To use the tool:
	1. Double Click on the XlsAutoFitTool.exe
	2. File browser will open. Select the excel file you want to autofit.
		(You can configure default path to open on clicking file broswer by setting that path in the config file)
	3. Wait for tool to complete opeartion.
	   (Log gets written into AutoFitXlsLog file in the tool folder. The log file also shows how many sheets are there in the selected excel file)
	4. Open the selected excel file. It should be auto fitted.
