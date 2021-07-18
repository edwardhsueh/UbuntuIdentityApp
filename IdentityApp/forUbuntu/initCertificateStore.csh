#!/bin/bash
mkdir -p $HOME/.pki/nssdb
certutil -d $HOME/.pki/nssdb -N