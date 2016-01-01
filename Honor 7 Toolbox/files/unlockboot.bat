echo off
cd files
echo ===============================================================================
echo ***                    HONOR 7 ToolBox by TheMegaPhoenix                    ***
echo ***                       Unlocking the bootloader                          ***
echo ===============================================================================
echo    *************************************************************************
echo    **                       ! ! ! ATTENTION  ! ! !                        **
echo    **                                                                     ** 
echo    **          Unlocking your bootloader voids your warranty!             ** 
echo    **                                                                     ** 
echo    **            Please enable USB Debugging in your phone!               **
echo    **       Unlock your phone and follow the messages displayed           **
echo    **                                                                     **
echo    **                                                                     **
echo    **        You need to have the code from the website ready             **
echo    **           The unlock code should consist of 16 characters           **
echo    *************************************************************************
echo.
echo.
echo ===============================================================================
echo ***            Please type the unlock code and press "Enter"                ***
echo ===============================================================================
echo.
set /p input=""
adb reboot bootloader
fastboot devices
fastboot oem unlock %input%
pause
fastboot reboot
exit
