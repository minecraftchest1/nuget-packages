#!/bin/bash
dotnet build ./utils
doxygen Doxyfile
cp ./Doxygen/html/* ./docs -r
