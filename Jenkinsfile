pipeline{
    agent any
    stages{
        stage("Clean Up"){
            steps{
                deleteDir()
            }
        }
        stage("Clone Repo"){
            steps{
                sh "git clone https://github.com/tanachote-su/hello_devops.git"
            }
        }
        stage("Build Docker Image"){
            steps{
                echo "Clean Environment ..."
                sh "docker rm -f hello_devops"
                sh "docker rmi -f hello_devops"
                echo
                echo "Build image && Run container in background ..."
                sh "docker build -f ./hello_devops/Dockerfile -t hello_devops ."
                sh "docker run -d --name hello_devops hello_devops"
            }
        }                        
    }
}