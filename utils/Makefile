utils_files = $(wildcard utils/*.cs)
utils_bin = $(wildcard utils/bin/*)

utils : utils/Utils.cs utils/Exceptions.cs Force
	dotnet build utils/
