cd ../build
call build.bat
cd ../pack
call ./pack.bat
cd ../publish
call ./copy.bat LogoFX.Client.Tests.Integration.NUnit 2.2.0-rc2 %1