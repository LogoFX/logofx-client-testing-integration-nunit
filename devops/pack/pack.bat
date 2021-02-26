cd contents
rmdir /Q /S lib
mkdir lib
cd lib
mkdir netstandard2.0\
robocopy ../../../../src/Bin/netstandard/Release netstandard2.0 LogoFX.Client.Testing.Integration.NUnit.* /E
cd ../../
nuget pack contents/LogoFX.Client.Tests.Integration.NUnit.nuspec -OutputDirectory ../../output