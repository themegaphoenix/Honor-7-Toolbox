echo off
cd files
cls
color 0C
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
echo    **        The unlock code should consist of 16 characters              **
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
pause

:flashReco
cls
echo ===============================================================================
echo ***                    HONOR 7 ToolBox by TheMegaPhoenix                    ***
echo ===============================================================================
echo.
echo                       Bootloader unlocked sucessfully!
echo. 
echo                 Do you want to flash a custom recovery (TWRP)?                            
echo.                                                      
echo.                      
echo ===============================================================================
echo ***                Select "Y" or "N" and press "Enter"                   ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
if /I '%input%'=='Y' call flashTWRP
if /I '%input%'=='N' goto exit
