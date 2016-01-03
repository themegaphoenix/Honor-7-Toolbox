echo off
cd files
:RCVRMODE
cls
color 0C
echo ===============================================================================
echo ***                    HONOR 7 ToolBox by TheMegaPhoenix                    ***
echo ***                         Booting to recovery                             ***
echo ===============================================================================
adb kill-server
adb reboot recovery
exit