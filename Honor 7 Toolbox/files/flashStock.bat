echo off
cd files
if not exist ".\REC\L01" mkdir .\REC\L01
if not exist ".\REC\AL10" mkdir .\REC\AL10
if not exist ".\REC\TL00" mkdir .\REC\TL00
if not exist ".\REC\TL01H" mkdir .\REC\TL01H
if not exist ".\REC\UL00" mkdir .\REC\UL00
if not exist ".\REC\CL00" mkdir .\REC\CL00
:menu
cls
color 0C
echo ===============================================================================
echo ***                    HONOR 7 ToolBox by TheMegaPhoenix                    ***
echo ***                         Flashing stock Recovery                         ***
echo ===============================================================================
echo.
echo  Select the model of your device :
echo.
echo     1: PLK-L01                             
echo     2: PLK-AL10                           
echo     3: PLK-UL00
echo     *: PLK-CL00 (not available)
echo     5: PLK-TL01H 
echo     *: PLK-TL00 (not available)
echo.
echo.
echo    M: Back to the main menu
echo    X: CLOSE UTILITY
echo.
echo.
echo ===============================================================================
echo ***               Select a number or letter and press "Enter"               ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
if '%input%'=='1' goto L01
if '%input%'=='2' goto AL10
if '%input%'=='3' goto UL00
REM if '%input%'=='4' goto CL00
if '%input%'=='5' goto TL01H
REM if '%input%'=='6' goto TL00
if /I '%input%'=='M' goto MAINMENU
if /I '%input%'=='X' goto EXIT
goto MODEL_MENU_VERIFY

REM ************************************** L01 *************************************

:L01
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo                   Stock Recovery selection menu
echo.
echo    1: Flash stock Recovery B100_EU
echo    2: Flash stock Recovery B110_RU
echo    3: Flash stock Recovery B120_RU
echo    4: Flash stock Recovery B121_EU
echo    5: Flash stock Recovery B130_EU
echo    6: Flash stock Recovery B140_EU
echo    7: Flash stock Recovery B313_EU
echo.
echo    M: Back to the main menu                     
echo    B: Back to the selection of the models
echo    X: CLOSE UTILITY
echo.
echo.
echo ===============================================================================
echo ***               Select a number or letter and press "Enter"               ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
if '%input%'=='1' goto L01_B100
if '%input%'=='2' goto L01_B110
if '%input%'=='3' goto L01_B120
if '%input%'=='4' goto L01_B121
if '%input%'=='5' goto L01_B130
if '%input%'=='6' goto L01_B140
if '%input%'=='7' goto L01_B313
if /I '%input%'=='M' goto MAINMENU
if /I '%input%'=='B' goto MODEL_MENU_VERIFY
if /I '%input%'=='X' goto EXIT
goto L01

:L01_B100
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                    Flashing Stock Recovery L01-B100_EU                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\L01\SR_L01_B100.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\L01\SR_L01_B100.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                 Dowloading Stock Recovery L01-B100_EU                   ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/L01/SR_L01_B110.zip "https://copy.com/wNcPKD671V0a7rnL/SR_L01_B100.zip?download=1"
7z x ./REC/L01/SR_L01_B100.zip -o./REC/L01/
del .\REC\L01\SR_L01_B100.zip
goto L01_B100
)
pause
goto MAINMENU

:L01_B110
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                     Flashing Stock Recovery L01-B110                    ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\L01\SR_L01_B110.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\L01\SR_L01_B110.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                   Downloading Stock Recovery L01-B110                   ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/L01/SR_L01_B110.zip "https://copy.com/1OvAz6dRL0Swk6Up/SR_L01_B110.zip?download=1"
7z x ./REC/L01/SR_L01_B110.zip -o./REC/L01/
del .\REC\L01\SR_L01_B110.zip
goto L01_B110
)
pause
goto MAINMENU

:L01_B120
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                        Flashing Stock Recovery B120                     ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\L01\SR_L01_B120.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\L01\SR_L01_B120.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                       Downloading Stock Recovery B120                   ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/L01/SR_L01_B120.zip "https://copy.com/O8od4mldP14egVD7/SR_L01_B120.zip?download=1"
7z x ./REC/L01/SR_L01_B120.zip -o./REC/L01/
del .\REC\L01\SR_L01_B120.zip
goto L01_B120
)
pause
goto MAINMENU

:L01_B121
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                        Flashing Stock Recovery B121                     ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\L01\SR_L01_B121.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\L01\SR_L01_B121.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                     Downloading Stock Recovery B121_EU                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/L01/SR_L01_B121.zip "https://copy.com/wEeXFKdpAR1eRO72/SR_L01_B121.zip?download=1"
7z x ./REC/L01/SR_L01_B121.zip -o./REC/L01/
del .\REC\L01\SR_L01_B121.zip
goto L01_B121
)
pause
goto MAINMENU

:L01_B130
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                      Flashing Stock Recovery B130_EU                    ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\L01\SR_L01_B130.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\L01\SR_L01_B130.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                      Downloading Stock Recovery B130_EU                 ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/L01/SR_L01_B130.zip "https://copy.com/HOgspTQgTGHshDNW/SR_L01_B130.zip?download=1"
7z x ./REC/L01/SR_L01_B130.zip -o./REC/L01/
del .\REC\L01\SR_L01_B130.zip
goto L01_B130
)
pause
goto MAINMENU

:L01_B140
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                      Flashing Stock Recovery B140_EU                    ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\L01\SR_L01_B140.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\L01\SR_L01_B140.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                     Downloading Stock Recovery B140_EU                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/L01/SR_L01_B140.zip "https://copy.com/d6DGPShglhTjizIf/SR_L01_B140.zip?download=1"
7z x ./REC/L01/SR_L01_B140.zip -o./REC/L01/
del .\REC\L01\SR_L01_B140.zip
goto L01_B140
)
pause
goto MAINMENU


:L01_B313
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                      Flashing Stock Recovery B313_EU                    ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\L01\SR_L01_B313.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\L01\SR_L01_B313.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-L01                                 ***
echo ===============================================================================
echo.
echo ***                     Downloading Stock Recovery B313_EU                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/L01/SR_L01_B313.zip "https://copy.com/WLmoJswrHhEPvKeH/SR_L01_B313.zip?download=1"
7z x ./REC/L01/SR_L01_B313.zip -o./REC/L01/
del .\REC\L01\SR_L01_B313.zip
goto L01_B313
)
pause
goto MAINMENU

REM ************************************** CL00 *************************************

:CL00
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-‘L00                                ***
echo ===============================================================================
echo.
echo                   Restore stock recovery selection menu:
echo.
echo    *: Flash stock Recovery B188.
echo    *: Flash stock Recovery B708.
echo    *: Flash stock Recovery .
echo    *: Flash stock Recovery .
echo    *: Flash stock Recovery 615 5.12.1.
echo.
echo    M: Back to the main menu                     
echo    B: Back to the selection of the models
echo    X: CLOSE UTILITY
echo.
echo.
echo ===============================================================================
echo ***               Select a number or letter and press "Enter"               ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
rem if '%input%'=='1' goto ‘L00_B188
rem if '%input%'=='2' goto ‘L00_B708
rem if '%input%'=='3' goto CL00_B120
rem if '%input%'=='4' goto CL00_B133
rem if '%input%'=='5' goto CL00_B615
if /I '%input%'=='M' goto MAINMENU
if /I '%input%'=='B' goto MODEL_MENU_VERIFY
if /I '%input%'=='X' goto EXIT
goto CL00


REM ************************************** TL00 *************************************

:TL00
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-TL00                                ***
echo ===============================================================================
echo.
echo                   Restore stock recovery selection menu:
echo.
echo    *: Flash stock Recovery B188
echo    *: Flash stock Recovery B708
echo    *: Flash stock Recovery B709 5.11.1
echo    *: Flash stock Recovery B600 5.11.16
echo    *: Flash stock Recovery B615 5.12.1
echo    *: Flash stock Recovery B618 5.12.16
echo.
echo    M: Back to the main menu                     
echo    B: Back to the selection of the models
echo    X: CLOSE UTILITY
echo.
echo.
echo ===============================================================================
echo ***               Select a number or letter and press "Enter"               ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
rem if '%input%'=='1' goto TL00_B188
rem if '%input%'=='2' goto TL00_B708
rem if '%input%'=='3' goto TL00_B120
rem if '%input%'=='4' goto TL00_B133
rem if '%input%'=='5' goto TL00_B615
if /I '%input%'=='M' goto MAINMENU
if /I '%input%'=='B' goto MODEL_MENU_VERIFY
if /I '%input%'=='X' goto EXIT
goto TL00

REM ************************************** UL00 *************************************

:UL00
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-UL00                                ***
echo ===============================================================================
echo.
echo                   Restore stock recovery selection menu:
echo.
echo    *: Flash stock Recovery B188
echo    *: Flash stock Recovery B708
echo    *: Flash stock Recovery ***
echo    *: Flash stock Recovery ***
echo    5: Flash stock Recovery 615 5.12.1
echo    *: Flash stock Recovery 618 5.12.16
echo.
echo    M: Back to the main menu                     
echo    B: Back to the selection of the models
echo    X: CLOSE UTILITY
echo.
echo.
echo ===============================================================================
echo ***               Select a number or letter and press "Enter"               ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
rem if '%input%'=='1' goto UL00_B188
if '%input%'=='2' goto UL00_B708
rem if '%input%'=='3' goto UL00_
rem if '%input%'=='4' goto UL00_
if '%input%'=='5' goto UL00_B615
if /I '%input%'=='M' goto MAINMENU
if /I '%input%'=='B' goto MODEL_MENU_VERIFY
if /I '%input%'=='X' goto EXIT
goto UL00

:UL00_B708
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-UL00                                ***
echo ===============================================================================
echo.
echo **                          Flashing Stock Recovery B708                    ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\UL00\SR_UL00_B708.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\UL00\SR_UL00_B708.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PE-UL00                                 ***
echo ===============================================================================
echo.
echo ***                       Downloading Stock Recovery B708                   ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/UL00/SR_UL00_B708.zip "null"
7z x ./REC/UL00/SR_UL00_B708.zip -o./REC/UL00/
del .\REC\UL00\SR_UL00_B708.zip
goto UL00_B708
)
pause
goto MAINMENU

:UL00_B615
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-UL00                                ***
echo ===============================================================================
echo.
echo **                          Flashing Stock Recovery B615                    ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\UL00\SR_UL00_B615.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\UL00\SR_UL00_B615.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PE-UL00                                 ***
echo ===============================================================================
echo.
echo ***                       Downloading Stock Recovery B615                   ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/UL00/SR_UL00_B615.zip "https://copy.com/YATROSCyQs8v3qln/SR_UL00_B615.zip?download=1"
7z x ./REC/UL00/SR_UL00_B615.zip -o./REC/UL00/
del .\REC\UL00\SR_UL00_B615.zip
goto UL00_B615
)
pause
goto MAINMENU

REM ************************************** AL10 *************************************

:AL10
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo.
echo                   Restore stock recovery selection menu:
echo.
echo    1: Flash stock Recovery B173
echo    2: Flash stock Recovery B188
echo    *: Flash stock Recovery B708
echo    4: Flash stock Recovery B709 5.11.1 
echo    *: Flash stock Recovery B600 5.11.16 
echo    6: Flash stock Recovery B615 5.12.1 
echo.
echo    M: Back to the main menu                     
echo    B: Back to the selection of the models
echo    X: CLOSE UTILITY
echo.
echo.
echo ===============================================================================
echo ***               Select a number or letter and press "Enter"               ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
if '%input%'=='1' goto AL10_B173
if '%input%'=='2' goto AL10_B188
rem if '%input%'=='3' goto AL10_B708
if '%input%'=='4' goto AL10_B709
rem if '%input%'=='4' goto AL10_B600
if '%input%'=='6' goto AL10_B615
if /I '%input%'=='M' goto MAINMENU
if /I '%input%'=='B' goto MODEL_MENU_VERIFY
if /I '%input%'=='X' goto EXIT
goto AL10


:AL10_B173
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo. 
echo **                          Flashing Stock Recovery B173                    ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\AL10\SR_AL10_B173.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\AL10\SR_AL10_B173.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo.
echo ***                        Downloading Stock Recovery B173                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/AL10/SR_AL10_B173.zip "https://copy.com/yaVP33M2X4NNwdCc/SR_AL10_B173.zip?download=1"
7z x ./REC/AL10/SR_AL10_B173.zip -o./REC/AL10/
del .\REC\AL10\SR_AL10_B173.zip
goto AL10_B173
)
pause
goto MAINMENU


:AL10_B188
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo. 
echo **                          Flashing Stock Recovery B188                    ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\AL10\SR_AL10_B188.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\AL10\SR_AL10_B188.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo.
echo ***                        Downloading Stock Recovery B188                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/AL10/SR_AL10_B188.zip "https://copy.com/G3YYD4ct386kaSKb/SR_AL10_B188.zip?download=1"
7z x ./REC/AL10/SR_AL10_B188.zip -o./REC/AL10/
del .\REC\AL10\SR_AL10_B188.zip
goto AL10_B188
)
pause
goto MAINMENU

:AL10_B709
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo.
echo **                     Flashing Stock Recovery B709 5.11.1                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\AL10\SR_AL10_B709.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\AL10\SR_AL10_B709.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo.
echo ***                 Downloading Stock Recovery B709 5.11.1                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/AL10/SR_AL10_B709.zip "https://copy.com/LsVP7re6zKsUjGrp/SR_AL10_B709.zip?download=1"
7z x ./REC/AL10/SR_AL10_B709.zip -o./REC/AL10/
del .\REC\AL10\SR_AL10_B709.zip
goto AL10_B709
)
pause
goto MAINMENU

:AL10_B615
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo.
echo **                     Flashing Stock Recovery B615 5.12.1                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\AL10\SR_AL10_B615.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\AL10\SR_AL10_B615.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo.
echo ***                  Downloading Stock Recovery B615 5.12.1                 ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/AL10/SR_AL10_B615.zip "https://copy.com/r8zpSHIPih4TvUVC/SR_AL10_B615.zip?download=1"
7z x ./REC/AL10/SR_AL10_B615.zip -o./REC/AL10/
del .\REC\AL10\SR_AL10_B615.zip
goto AL10_B615
)
pause
goto MAINMENU

:L01_B618
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo.
echo **                    Flashing Stock Recovery B618 5.12.16                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\AL10\SR_AL10_B618.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\AL10\SR_AL10_B618.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-AL10                                ***
echo ===============================================================================
echo.
echo ***                Downloading Stock Recovery B618 5.12.16                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/AL10/SR_AL10_B618.zip "https://copy.com/ITjhfyoxR29PTb10/SR_AL10_B618.zip?download=1"
7z x ./REC/AL10/SR_AL10_B618.zip -o./REC/AL10/
del .\REC\AL10\SR_AL10_B618.zip
goto L01_B618
)
pause
goto MAINMENU

REM ************************************** TL01H *************************************

:TL01H
cls
color 0A
echo.
echo ===============================================================================
echo ***                                PLK-TL01H                                ***
echo ===============================================================================
echo.
echo                   Restore stock recovery selection menu:
echo.
echo    *: Flash stock Recovery B188
echo    2: Flash stock Recovery B708
echo    *: Flash stock Recovery B709 5.11.1 
echo    *: Flash stock Recovery B600 5.11.16 
echo    5: Flash stock Recovery B615 5.12.1 
echo    6: Flash stock Recovery B618 5.12.16 
echo.
echo    M: Back to the main menu                     
echo    B: Back to the selection of the models
echo    X: CLOSE UTILITY
echo.
echo.
echo ===============================================================================
echo ***               Select a number or letter and press "Enter"               ***
echo ===============================================================================
echo.
set /p input=Please enter your choice:
rem if '%input%'=='1' goto TL01H_B188
if '%input%'=='2' goto TL01H_B708
rem if '%input%'=='3' goto TL01H_B709
rem if '%input%'=='4' goto TL01H_B600
if '%input%'=='5' goto TL01H_B615
if '%input%'=='6' goto TL01H_B618
if /I '%input%'=='M' goto MAINMENU
if /I '%input%'=='B' goto MODEL_MENU_VERIFY
if /I '%input%'=='X' goto EXIT
goto TL01H

:TL01H_B188
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo. 
echo **                          Flashing Stock Recovery B188                    ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\TL01H\SR_TL01H_B188.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\TL01H\SR_TL01H_B188.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                PLK-TL01H                                ***
echo ===============================================================================
echo.
echo ***                    Downloading Stock Recovery B188                      ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/TL01H/SR_TL01H_B188.zip "null"
7z x ./REC/TL01H/SR_TL01H_B188.zip -o./REC/TL01H/
del .\REC\TL01H\SR_TL01H_B188.zip
goto TL01H_B188
)
pause
goto MAINMENU

:TL01H_B708
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo **                         Flashing Stock Recovery B708                     ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\TL01H\SR_TL01H_B708.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\TL01H\SR_TL01H_B708.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo ***                    Downloading Stock Recovery B708                      ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/TL01H/SR_TL01H_B708.zip "https://copy.com/TQ4h2XDz3dCdCBqD/SR_TL01H_B708.zip?download=1"
7z x ./REC/TL01H/SR_TL01H_B708.zip -o./REC/TL01H/
del .\REC\TL01H\SR_TL01H_B708.zip
goto TL01H_B708
)
pause
goto MAINMENU

:TL01H_B709
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo **                     Flashing Stock Recovery B709 5.11.1                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\TL01H\SR_TL01H_B709.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\TL01H\SR_TL01H_B709.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo ***                Downloading Stock Recovery B709 5.11.1                   ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/TL01H/SR_TL01H_B709.zip "null"
7z x ./REC/TL01H/SR_TL01H_B709.zip -o./REC/TL01H/
del .\REC\TL01H\SR_TL01H_B709.zip
goto TL01H_B709
)
pause
goto MAINMENU

:TL01H_B600
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo **                     Flashing Stock Recovery B600 5.11.16                 ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\TL01H\SR_TL01H_B600.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\TL01H\SR_TL01H_B600.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo ***                Downloading Stock Recovery B600 5.11.16                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/TL01H/SR_TL01H_B600.zip "null"
7z x ./REC/TL01H/SR_TL01H_B600.zip -o./REC/TL01H/
del .\REC\TL01H\SR_TL01H_B600.zip
goto TL01H_B600
)
pause
goto MAINMENU

:TL01H_B615
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo **                    Flashing Stock Recovery B615 5.12.1                   ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\TL01H\SR_TL01H_B615.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\TL01H\SR_TL01H_B615.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo ***                   Downloading Stock Recovery B615 5.12.1                   ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/TL01H/SR_TL01H_B615.zip "https://copy.com/ih8FTHi2jBoabIdD/SR_TL01H_B615.zip?download=1"
7z x ./REC/TL01H/SR_TL01H_B615.zip -o./REC/TL01H/
del .\REC\TL01H\SR_TL01H_B615.zip
goto TL01H_B615
)
pause
goto MAINMENU


:TL01H_B618
cls
color 0A
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo **                    Flashing Stock Recovery B618 5.12.16                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
if exist .\REC\TL01H\SR_TL01H_B618.img (
adb kill-server
adb reboot bootloader
fastboot devices
fastboot flash recovery .\REC\TL01H\SR_TL01H_B618.img
fastboot reboot
adb wait-for-device
) ELSE (
cls
color 0E
echo.
echo ===============================================================================
echo ***                                 PLK-TL01H                               ***
echo ===============================================================================
echo.
echo ***                Downloading Stock Recovery B618 5.12.16                  ***
echo.
echo ===============================================================================
echo ***                             Please Wait                                 ***
echo ===============================================================================
echo.
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./REC/TL01H/SR_TL01H_B618.zip "https://copy.com/ytj0nvOcuLgs9Ret/SR_TL01H_B618.zip?download=1"
7z x ./REC/TL01H/SR_TL01H_B618.zip -o./REC/TL01H/
del .\REC\TL01H\SR_TL01H_B618.zip
goto TL01H_B618
)
pause
goto MAINMENU