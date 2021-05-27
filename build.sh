#!/bin/bash
dotnet build .\utils\
doxygen Doxyfile
cp .\html\ docs