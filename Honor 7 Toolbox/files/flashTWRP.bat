echo off
cd files
if not exist ".\REC" mkdir .\REC
:menu
cls
color 0C
echo ===============================================================================
echo ***                    HONOR 7 ToolBox by TheMegaPhoenix                    ***
echo ***                          Flashing TWRP Recovery                         ***
echo ===============================================================================
echo.
echo     Select the TWRP recovery to flash:
echo.
echo.
echo     1: Install TWRP 2.8.7.0 ALL 5.0.2
echo     2: Install TWRP 2.8.6.0 5.1.1 + RU
echo     3: Install TWRP 2.8.6.0 6.0 + EN
echo.
echo.
echo.
echo ===============================================================================
echo ***               Select a number or letter and press "Enter"               ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
if '%input%'=='1' goto TWRP_5.0.2
if '%input%'=='2' goto TWRP_5.1.1
if '%input%'=='3' goto TWRP_6.0
goto menu


:TWRP_5.0.2
cls
color 0A
echo.
echo ===============================================================================
echo ***              HONOR 7 Multi-Tool by inside!out %currentver%                ***
echo ===============================================================================
echo.
echo                     Chosen recovery:  TWRP 2.8.7.0 5.0.2
echo.
echo.
echo                 Please connect the Honor 7 in USB Debugging mode!
echo.
echo.
echo ===============================================================================
echo ***                           Please Wait                                  ***
echo ===============================================================================
echo.
if exist .\REC\TWRP_Honor7_EN.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\TWRP_Honor7_EN.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***              HONOR 7 Multi-Tool by inside!out %currentver%                ***
echo ===============================================================================
echo.
echo.
echo                       Downloading TWRP 2.8.7.0 5.0.2
echo.
echo               Please connect the Honor 7 in USB Debugging mode!
echo.
echo.
echo ===============================================================================
echo ***                           Please Wait                                   ***
echo ===============================================================================
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/TWRP_Honor7_EN.zip "https://copy.com/FUiCB1yQpbjNOQbE/TWRP_Honor7_EN.zip?download=1"
7z x ./REC/TWRP_Honor7_EN.zip -o./REC/
del .\REC\TWRP_Honor7_EN.zip
goto TWRP_5.0.2
)
goto ROOT

:TWRP_5.1.1
cls
color 0A
echo.
echo ===============================================================================
echo ***              HONOR 7 Multi-Tool by inside!out %currentver%                ***
echo ===============================================================================
echo.
echo.
echo                    Chosen recovery: TWRP 2.8.6.0 5.1.1 + RU
echo.
echo                Please connect the Honor 7 in USB Debugging mode!
echo.
echo.
echo ===============================================================================
echo ***                           Please Wait                                   ***
echo ===============================================================================
echo.
if exist .\REC\TWRP_5.1.1_CN.IMG (
adb kill-server
echo.
adb shell rm -r /sdcard/TWRP
echo.
adb shell mkdir /sdcard/TWRP
echo.
adb shell mkdir /sdcard/TWRP/theme/
echo.
adb push .\REC\ui.zip /sdcard/twrp/theme/
echo.
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\TWRP_5.1.1_CN.IMG
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***              HONOR 7 Multi-Tool by inside!out %currentver%                ***
echo ===============================================================================
echo.
echo.
echo                      Downloading TWRP 2.8.6.0 5.1.1 + RU
echo.
echo                Please connect the Honor 7 in USB Debugging mode!
echo.
echo.
echo ===============================================================================
echo ***                           Please Wait                                   ***
echo ===============================================================================
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/TWRP_5.1.1_CN.zip "https://copy.com/lINzi88gojQeiZLW/TWRP_5.1.1_CN.zip?download=1"
7z x ./REC/TWRP_5.1.1_CN.zip -o./REC/
del .\REC\TWRP_5.1.1_CN.zip
goto TWRP_5.1.1
)
goto ROOT


:TWRP_6.0
cls
color 0A
echo.
echo ===============================================================================
echo ***              HONOR 7 Multi-Tool by inside!out %currentver%                ***
echo ===============================================================================
echo.
echo.
echo                    Chosen recovery: TWRP 2.8.6.0 6.0 + EN
echo.
echo               Please connect the Honor 7 in USB Debugging mode!
echo.
echo.
echo ===============================================================================
echo ***                           Please Wait                              ***
echo ===============================================================================
echo.
if exist .\REC\TWRP_6.0_CN.IMG (
adb kill-server
echo.
adb shell rm -r /sdcard/TWRP
echo.
adb shell mkdir /sdcard/TWRP
echo.
adb shell mkdir /sdcard/TWRP/theme/
echo.
adb push .\REC\ui.zip /sdcard/twrp/theme/
echo.
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\TWRP_6.0_CN.IMG
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***              HONOR 7 Multi-Tool by inside!out %currentver%                ***
echo ===============================================================================
echo.
echo.
echo                       Downloading TWRP 2.8.6.0 6.0 + EN
echo.
echo                Please connect the Honor 7 in USB Debugging mode!
echo.
echo.
echo ===============================================================================
echo ***                           Please Wait                              ***
echo ===============================================================================
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/TWRP_6.0_CN.zip "https://copy.com/LKOgEnYczOBSx8tq/TWRP_6.0_CN.zip?download=1"
7z x ./REC/TWRP_6.0_CN.zip -o./REC/
del .\REC\TWRP_6.0_CN.zip
goto TWRP_6.0
)
goto ROOT

:ROOT
cls
echo ===============================================================================
echo ***                    HONOR 7 ToolBox by TheMegaPhoenix                    ***
echo ===============================================================================
echo.
echo                          TWRP flashed sucessfully!
echo. 
echo                       Do you want to root your phone?                            
echo.                                                      
echo.                      
echo ===============================================================================
echo ***                Select "Y" or "N" and press "Enter"                   ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
if /I '%input%'=='Y' call root
if /I '%input%'=='N' goto exit