Param(
    [Parameter(Mandatory=$True, Position=0)]
    [System.String] $Version
)

docker build -t test-samples/testing-in-docker .
docker tag petdoctor/petdoctor-api kanearmstrongdev.azurecr.io/petdoctor/petdoctor-api:$Version
docker push kanearmstrongdev.azurecr.io/petdoctor/petdoctor-api:$Version