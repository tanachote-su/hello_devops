pipeline{
    agent any
    stages{
        stage("Clean Up"){
            steps{
                deleteDir()
            }
        }        
        stage("Get Info"){
            steps{
                sh "pwd"
                sh "ifconfig"
            }
        }
        stage('List pods') {
            steps{
                sh '/usr/local/bin/kubectl get pods'
            }        
        }
        stage('Deployment') {
            steps{
                sh '/usr/local/bin/kubectl apply -f deployment.yaml'
            }        
        }        
    }
}