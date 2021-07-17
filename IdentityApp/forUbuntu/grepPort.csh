#!/bin/bash
sudo lsof -i -P -n | grep LISTEN | grep 5001
sudo lsof -i -P -n | grep LISTEN | grep 5000
sudo lsof -i -P -n | grep LISTEN | grep 80
sudo lsof -i -P -n | grep LISTEN | grep 443
