include utils/Makefile

#Defines the rules for the Minecraftchest1.Utils package
docs : utils
	doxygen
	cp Doxygen/html/* docs/ -r

clean :
	rm utils/bin -r

main : utils docs
	pwd

Force:
