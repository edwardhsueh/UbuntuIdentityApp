#!/bin/bash
# install az command tool first
az keyvault secret set --vault-name "EdwardDotNetKeyValut" --name "Authentication--Google--ClientId" --value "950792777676-h30pdra7fil29jtsl5l9n0sjvrnhkgdb.apps.googleusercontent.com"
az keyvault secret set --vault-name "EdwardDotNetKeyValut" --name "Authentication--Google--ClientSecret" --value "rD5eFSOScqjXG8ssOH-P2vQ5"
az keyvault secret set --vault-name "EdwardDotNetKeyValut" --name "Authentication--Facebook--AppId" --value "2979913789001540"
az keyvault secret set --vault-name "EdwardDotNetKeyValut" --name "Authentication--Facebook--AppSecret" --value "6b8a19035e47978765f71657015840b6"