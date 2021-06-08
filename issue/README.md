# Unable to push the code to github

When I push the code to github, the gitssh pop is up and asked to enter the username and password.
Then its pop up below messange on the gitbash.  
```bash
logon failed use ctrl+c to cancel basic credential prompt
```
How to solove it.  
Enter the below commands on gitbash  

```bash
git credential-manager uninstall --force
```

Then push the code and gitbash pop up a windoes for to enter the github crential.
Once entered the credential, Iam able to push the code.


