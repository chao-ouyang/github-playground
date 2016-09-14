# github-playground
place to do hands on training for github
## branch model
![](http://i.imgur.com/2IvTlOb.png)


## git cheat sheet
##### commands
* `git status` to check status
* `git checkout` to switch to branch
* `git checkout -b xxxx` to create & checkout new branch based on current working branch.
* `git add .` to add all changes to stage
* `git commit -m 'xxxxx'` commit staged changes to local repo with comment
* `git push -u origin xxxxx` push local commits to remote origin repo
* `git pull --rebase` to get the latest code with rebase.
* `git rebase develop` to rebase from develop branch to current working branch (feature branch).
* `git log --oneline --graph --color --since=2.weeks` print out git history log with graph within 2 weeks
* `git stash` save the current none commited changes, so that be able to switch to other branch.
* `git cheery-pick xxxxxx` & `git cherry-pick --continue -m 'commit message'`, xxxxxx is 6 digit SHA1 commit hash, if there merge conflict, user the `--continue` to commit the merge result.
* 

##### config
* `git config --global core.autocrlf true` for windows users
* `git config --global core.autocrlf input` for mac users
* `git config --global pull.rebase true` alwasy rebase when doing pull
* `git config --global push.default simple` make sure branch name matchs.


## github training

##### sprint 1 dev
###### _user 1_
1. get the latest code from remote `develop` branch.
2. make sprint1-task#001 branch from develop branch.  
 + `git checkout develop` to swtich to develop branch
 + `git pull --rebase` to get the lastest code. (to make it simple, set the default pull with rebase by default `git config --global pull.rebase true`)  
3. create new branch for the task. `git checkout -b sprint1-task#001`
4. append line  `//sprint 1, task#001` to CodeFile.cs
5. run commandline `git add .` to add all changes to stage for next commit
6. run commandline `git commit -am "sprint 1, task #001"` to commit all changes to local repo with commit message.
7. run commandline `git push --set-upstream origin sprint1-task#001` that push all local commits to remote origin.
8. create a `Pull request` from `sprint1-task#001` to `develop` on github.com web site, with `Assigness` user 2.
9. user 1 go to click `Merge Pull Request` on github.com; or click `Update from sprint1-task#001` on Github desktop app.
10. Delete branch `sprint1-task#001`.

###### _user 2_
1. get the latest code from remote `develop` branch.
2. make sprint1-task#001 branch from develop branch.  
 + `git checkout develop` to swtich to develop branch
 + `git pull --rebase` to get the lastest code.
3. create new branch for the task. `git checkout -b sprint1-task#002`
4. append line  `//sprint 1, task#002` to CodeFile.cs
5. run commandline `git add .` to add all changes to stage for next commit
6. run commandline `git commit -am "sprint 1, task #002"` to commit all changes to local repo with commit message.
7. run commandline `git push --set-upstream origin sprint1-task#002` that push all local commits to remote origin.
8. create a `Pull request` from `sprint1-task#002` to `develop` on github.com web site, with `Assigness` user 1.
9. user 1 go to click `Merge Pull Request` on github.com; or click `Update from sprint1-task#002` on Github desktop app.
10. Delete branch `sprint1-task#002`.

##### sprint 1 deploy to test
1. create a `Pull Request` from `develop` to `master`, with `Assigness` user 3
2. user 1 go to click `Merge Pull Request` on github.com; or click `Update from develop` on Github desktop app. (keep the `develop` branch)
3. this trigger auto build and deploy to test site. build alert email send to user 3

##### sprint 1 deploy to uat (optional step)
1. create a `Pull Request` from `master` to `release`, with `Assigness` user 3, if `release` no exist, create a new branch `release` from `master`.
2. user 1 go to click `Merge Pull Request` on github.com; or click `Update from master` on Github desktop app. (keep the `master` branch)
3. this `release` branch is optional, handy when need to do hotfix on prod later.

##### sprint 1 hotfix
1. checkout `release` branch,
2. create a new branch for hotfix coding, namaed `sprint1-task#001-hotfix`.
3. open CodeFile.cs, add the text `hotfix` at the end of the line `//sprint 1, task#002` with a space.
4. add, commit & push the changes to remote origin branch `sprint1-task#001-hotfix`.
5. create `Pull Request` to review & merge into `release` branch.
6. manully deploy the build artifact `package.zip` to `staging` environment. QA test on staging.
7. QA signoff the fix, trigger the deploy to prod.
8. Cherry-pick the commit from `release` branch to develop branch by running command line: `git cherry-pick xxxxxx`. xxxxx is the commit hash in 6 digits.
9. If you have merging conflict, fix the issue and contine cherry-pick: run commandline `git add .` then `git cherry-pick --continue -m 'commit message'`
10. commit & push the merge result to remote origin `develop` branch.

##### sprint 2 dev
1. get the latest code from remote `develop` branch.
2. make sprint2-task#003 branch from develop branch.  
 + `git checkout develop` to swtich to develop branch
 + `git pull --rebase` to get the lastest code.
3. create new branch for the task. `git checkout -b sprint2-task#003`
4. append line  `//sprint 2, task#003` to CodeFile.cs (you should see the upper line as `//sprint 1, task#002 hotfix `)
5. run commandline `git add .` to add all changes to stage for next commit
6. run commandline `git commit -am "sprint 2, task #003"` to commit all changes to local repo with commit message.
7. run commandline `git push --set-upstream origin sprint2-task#003` that push all local commits to remote origin.
8. create a `Pull request` from `sprint2-task#032` to `develop` on github.com web site, with `Assigness` user 1.
9. user 1 go to click `Merge Pull Request` on github.com; or click `Update from sprint2-task#003` on Github desktop app.
10. Delete branch `sprint2-task#003`.

