@echo off
setlocal ENABLEDELAYEDEXPANSION

PowerShell -NonInteractive -NoProfile -ExecutionPolicy Unrestricted -Command ".\build\qa.ps1 -version $env:VERSION -artifactoryUser $env:REPOX_QAPUBLICADMIN_USERNAME -artifactoryPass $env:REPOX_QAPUBLICADMIN_PASSWORD"
echo From Cmd.exe: qa.ps1 exited with exit code !errorlevel!
exit !errorlevel!