docker build -t sdg-lightsaber-central .

docker tag sdg-lightsaber-central registry.heroku.com/saberstore/web

docker push registry.heroku.com/saberstore/web

heroku container:release web -a saberstore