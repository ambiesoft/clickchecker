setlocal
set APPNAME=clickchecker
C:\local\python3\python.exe ..\distSolution\distSolution.py --show-dummygitrev-csharp > "%~dp0%APPNAME%\gitrev.cs"