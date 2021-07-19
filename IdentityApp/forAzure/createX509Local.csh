#!/bin/bash
openssl genrsa 2048 > IdentityAppUbuntuLocalPrivate.key
openssl req -new -x509 -nodes -sha1 -days 1000 -key IdentityAppUbuntuLocalPrivate.key > IdentityAppUbuntuLocal.cer
openssl pkcs12 -export -in IdentityAppUbuntuLocal.cer -inkey IdentityAppUbuntuLocalPrivate.key -out IdentityAppUbuntuLocal.p12
