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
                dir('hello_devops') {
                    sh "pwd"
                    echo "Clean Environment ..."
                    sh "docker rm -f hello_devops"
                    sh "docker rmi -f hello_devops"
                    echo ""
                    echo "Build image && Run container in background ..."
                    sh "docker build -f ./hello_devops/Dockerfile -t hello_devops ."
                    sh "docker run -d --name hello_devops hello_devops"
                }
            }
        }
        stage("Deployment"){
            steps{
                dir('hello_devops/manifest') {
                    sh "pwd"

                }
            }
        }                          
    }
}
-----------------------------------------
        stage("Clone Repo"){
            steps{
                sh "git clone https://github.com/tanachote-su/hello_devops.git"
            }
        }

        stage("SSH Into k8s Server") {
                def remote = [:]
                remote.name = 'k8s-master'
                remote.host = '54.151.162.184'
                remote.user = 'k8sadmin'
                remote.password = 'k8sadmin'
                remote.allowAnyHosts = true
        } 

        ansiblePlaybook credentialsId: 'k8s-master', disableHostKeyChecking: true, installation: 'ansible', inventory: 'dev.inv', playbook: 'boook-deployment.yaml'