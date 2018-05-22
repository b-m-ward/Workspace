### Remove solution files that should be gitignored [[Link](https://stackoverflow.com/questions/1274057/how-to-make-git-forget-about-a-file-that-was-tracked-but-is-now-in-gitignore)] :
1. `git rm -r --cached .`
2. `git add .`
3. `git commit -m "message"`
