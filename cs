#!/usr/local/bin/python3

import os
import subprocess

def main(filename, args=None):
    if '.' not in filename:
        filename = filename + ".c"
    # we're too lazy to slap tab key twice to get the exact file name so..
    target = filename[:-2]
    if os.path.exists(target):
        os.remove(target)

    print("[+] Compiling {}".format(filename))

    if args:
        cmdStr = "gcc " + filename + "-o " + target + " " + str(args)
        print("[+] CMD: %s" % cmdStr)
        cmd = subprocess.Popen(["gcc", filename, "-o", target, args], stderr=subprocess.PIPE)
        error = cmd.communicate()
    else:
        cmdStr = "gcc " + filename + "-o " + target + " "
        print("[+] CMD: %s" % cmdStr)
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
    elif len(sys.argv) > 2:
        main(sys.argv[1], sys.argv[2])
    else:
        main(sys.argv[1])
