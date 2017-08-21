print "Locating VS 2015 tools directory"
cd "C:\Program Files (x86)\Microsoft Visual Studio 14.0"

print "Building"
msbuild /property:Configuration=Release "E:\Projects\PatternsAntipatternsAndReusableCode\Refactori
ngWithLinq\RefactoringWithLinq.csproj"