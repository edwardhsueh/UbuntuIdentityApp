#!/bin/bash
sudo cp -p kestrel-IdentityApp.service /etc/systemd/system/.
## copy publish result to /var/www/IdentityApp
sudo rm  -rf /var/www/IdentityApp
sudo cp -rp ../bin/Release/net5.0 /var/www/IdentityApp
sudo chown azureuser:azureuser /var/www/IdentityApp/
sudo chmod -R 0755 /var/www/IdentityApp/
## copy static file to /var/www/IdentityApp/wwwroot
sudo cp -rp ../wwwroot/ /var/www/IdentityApp/.
chown azureuser:azureuser /var/www/IdentityApp/wwwroot/
chmod 755 /var/www/IdentityApp/wwwroot/

sudo systemctl daemon-reload
sudo systemctl enable kestrel-IdentityApp.service
sudo systemctl stop kestrel-IdentityApp.service
sudo systemctl start kestrel-IdentityApp.service
sudo systemctl status kestrel-IdentityApp.service
