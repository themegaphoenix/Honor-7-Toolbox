echo off
cd files
cls
color 0C
echo ===============================================================================
echo ***                    HONOR 7 ToolBox by TheMegaPhoenix                    ***
echo ***                       Unlocking the bootloader                          ***
echo ===============================================================================
echo    *************************************************************************
echo    **                          ! ! !  ATTENTION ! ! !                     **
echo    **                                                                     **
echo    **            Please enable USB Debugging in your phone!               **
echo    **       Unlock your phone and follow the messages displayed           **
echo    **                                                                     **
echo    **                                                                     **
echo    **    Before you RELOCK Bootloader you need to restore the device's    **
echo    **     software to official version using 3 buttons flash method.      **
echo    *************************************************************************
echo.
echo               The unlock code should consist of 16 characters.
echo.
echo ===============================================================================
echo ***            Please type the unlock code and press "Enter"                ***
echo ===============================================================================
echo.
set /p input=""
adb reboot bootloader
fastboot devices
fastboot oem relock %input%
pause
fastboot reboot