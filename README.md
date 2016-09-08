# github-playground
place to do hands on training for github
## branch model
![](http://i.imgur.com/2IvTlOb.png)
## github training

##### sprint 1 dev
###### _user 1_
1. get the latest code from remote.
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
1. get the latest code from remote.
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
1. checkout `release branch`
Cherry-pick the commit to develop branch: `git cherry-pick xxxxxx`
If you have merging conflict, fix the issue and contine cherry-pick: `git cherry-pick --continue`

##### sprint 2 dev

