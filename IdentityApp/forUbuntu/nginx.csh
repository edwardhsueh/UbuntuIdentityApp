#!/bin/bash
sudo cp -p default /etc/nginx/sites-available/default 
# systemctl status nginx
sudo systemctl stop nginx
sudo nginx -t
sudo systemctl start nginx
systemctl status nginx
