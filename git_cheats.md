### Remove solution files that should be gitignored [[Link](https://stackoverflow.com/questions/1274057/how-to-make-git-forget-about-a-file-that-was-tracked-but-is-now-in-gitignore)] :
1. `git rm -r --cached .`
2. `git add .`
3. `git commit -m "message"`

### Revert to previous commit [[Link](https://stackoverflow.com/questions/4114095/how-to-revert-git-repository-to-a-previous-commit)]:
1. `git revert --no-commit hash..HEAD` where hash is the first 8 digits of the commit hash
2. `git commit` message optional
3. `git push origin master`

### No available terminals (git bash errors out) [[Link](https://stackoverflow.com/questions/45799650/git-bash-error-could-not-fork-child-process-there-are-no-available-terminals)]
