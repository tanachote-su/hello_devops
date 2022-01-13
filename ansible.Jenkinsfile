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
        
        stage("ansible test"){
            steps{
                dir('hello_devops/manifest') {
                    sh "pwd"
                    sh "ls -la"
                    ansiblePlaybook credentialsId: 'k8s-master', disableHostKeyChecking: true, installation: 'ansible', inventory: 'dev.inv', playbook: 'book-deployment.yaml'
                }
            }
        }
    }
}