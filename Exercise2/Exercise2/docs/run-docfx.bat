@echo off
cd /d %~dp0
docfx docfx.json --serve
pause