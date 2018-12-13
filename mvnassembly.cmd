@echo off
set JAVA_HOME=C:\Program Files\Java\jdk1.8.0_181
set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework

if exist "%~dp0\tools\lib\maven-2.0.9-uber.jar" goto mvn
call "%~dp0\tools\loadTools.cmd"

:mvn
@call "%~dp0tools\bin\mvn.bat" install -Dmaven.test.skip=true assembly:assembly %*