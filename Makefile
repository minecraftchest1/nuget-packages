include utils/Makefile

#Defines the rules for the Minecraftchest1.Utils package
docs : utils
	doxygen

clean :
	rm utils/bin -r

main : utils docs
	pwd

Force:
