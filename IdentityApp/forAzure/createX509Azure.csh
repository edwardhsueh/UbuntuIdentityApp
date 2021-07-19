#!/bin/bash
openssl genrsa 2048 > IdentityAppUbuntuAzurePrivate.key
openssl req -new -x509 -nodes -sha1 -days 1000 -key IdentityAppUbuntuAzurePrivate.key > IdentityAppUbuntuAzure.cer
openssl pkcs12 -export -in IdentityAppUbuntuAzure.cer -inkey IdentityAppUbuntuAzurePrivate.key -out IdentityAppUbuntuAzure.p12
