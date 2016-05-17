import os
import sys
from win32com.client import Dispatch

#Creating a logging file for this script
scriptLoc = os.path.dirname(os.path.abspath(__file__))
if os.path.exists(scriptLoc+'\\AutoFitXlsLog.log'):
	os.remove(scriptLoc+'\\AutoFitXlsLog.log')
scriptLogFile = open(scriptLoc+'\\AutoFitXlsLog.log', 'w')

xlsFile = str(sys.argv[1])
scriptLogFile.write("Path to excel file: " + xlsFile + "\n\n")

xl= Dispatch("Excel.Application")
xl.Visible = False # otherwise excel is hidden

# newest excel does not accept forward slash in path
wb = xl.Workbooks.Open(xlsFile)
#print "count of sheets:", wb.Sheets.Count
noSheets = wb.Sheets.Count
scriptLogFile.write("No. of sheets in the xls: " + str(noSheets) + "\n\n")

for i in range( 1, wb.Sheets.Count+1):
	xl.Worksheets(i).Activate()
	xl.ActiveSheet.Columns.AutoFit()

scriptLogFile.write("All sheets in excel file have been auto fitted.\n\n")

wb.Save()
wb.Close()

scriptLogFile.close()