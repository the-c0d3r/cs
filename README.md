CS
---

A lazy gcc compiler wrapper that'll compile and execute your code for you. Firstly, it will remove the compile file output if it exists first, then it will call up gcc with the following command, `gcc filename.c -o filename` where filename is the argument you passed to the script. If there is any error in compilation, it will not try to execute the program. It will only show you the error message and halt the process. If it compiled successfully without any error, then it will launch the process.

For more convenience, `cs` command is able to handle if you didn't type full file name. For instance, there are two files, `filename.c` (source file) and `filename` (compiled), and you type `file` and then tab, your terminal will autocomplete it to only `filename` because it matches both files. You just need to press enter, and the `cs` script will add `.c` if it is not found in argument. Meaning, you can just type `cs file`, (tab) and then press (enter). 

This project is similar to what I did for java, [js compiler](https://github.com/the-c0d3r/js). 

> Laziness is a virtue for a programmer.


### Optional Symlink
To make it accessible system wide, you can symlink the file js to the system path.

    ln -s /path/to/js /usr/local/bin/js

