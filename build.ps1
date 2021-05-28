if ( Test-Path utils)
{
	dotnet.exe build .\utils\
}
else
{
	echo "The 'utils' folder does not exist."
	exit
}
if ( Test-Path utils)
{
	doxygen.exe Doxyfile
}
else
{
	echo "The 'Doxyfile' file does not exist."
if ( Test-Path html\)
{
	if ( Test-Path docs )
	{
		Robocopy.exe .\html\ docs		
	}
	else
	{
		New-Item -Type Directory docs
		Robocopy.exe .\html\ docs
	}
}
else
{
	echo "The 'html' folder does not exist."
	exit
}