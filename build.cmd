rm bin/ -r
C:\Development\visualfsharp\Debug\net40\bin\fsc.exe .\test.fs --target:library -O --out:bin\test_fs_optimized.dll

csc .\testcs.cs /target:library /optimize+ /debug- /out:bin\test_cs.dll

fsc.exe .\test.fs --target:library -O --out:bin\test_fs_original.dll 

fsianycpu --exec unitTests.fsx