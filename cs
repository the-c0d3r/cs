#!/usr/local/bin/python3 

import os
import subprocess

def main(filename):
    if '.' not in filename:
        filename = filename + ".c"
    # we're too lazy to slap tab key twice to get the exact file name so..
    target = filename[:-2]
    if os.path.exists(target):
        os.remove(target)

    print("[+] Compiling {}".format(filename))

    cmd = subprocess.Popen(["gcc", filename, "-o", target], stderr=subprocess.PIPE)
    error = cmd.communicate()

    if len(error[1]) == 0:
        print("[+] Compiled Successfully\n")
        print("="*80)
        os.system("./{}".format(target))
        print("\n" + "="*80)
    else:
        print("[!] Failed to compile")
        print("="*80)
        print(error[1].decode('utf-8'))


if __name__ == "__main__":
    import sys
    if len(sys.argv) < 2:
        print("Usage: cs file.c")
    else:
        main(sys.argv[1])
