echo off
if exist "./HuaweiUpdateExtractor/HuaweiUpdateExtractor.exe" (
cls
echo ===============================================================================
echo ***                    Opening the HuaweiUpdateExtractor                  ***
echo ===============================================================================
color 0A
cd HuaweiUpdateExtractor
start HuaweiUpdateExtractor.exe
exit
)
if not exist "./HuaweiUpdateExtractor/HuaweiUpdateExtractor.exe" (
echo ===============================================================================
echo ***                    Downloading HuaweiUpdateExtractor                 ***
echo ===============================================================================
wget --quiet --show-progress --progress=bar:force:noscroll --no-check-certificate -O ./HuaweiUpdateExtractor_0.9.9.3.zip "https://copy.com/FiB4mhXDR2CONs1F/HuaweiUpdateExtractor_0.9.9.3.zip?download=1"
7z x ./HuaweiUpdateExtractor_0.9.9.3.zip -o.\HuaweiUpdateExtractor
del .\HuaweiUpdateExtractor_0.9.9.3.zip 
cd HuaweiUpdateExtractor
start HuaweiUpdateExtractor.exe
exit
)
