pipeline{
    agent any
   
    stages{
        stage("ansible test"){
            steps{
                ansiblePlaybook credentialsId: 'k8s-master', disableHostKeyChecking: true, installation: 'ansible', inventory: './hello_devops/manifest/dev.inv', playbook: './hello_devops/manifest/boook-deployment.yaml' 
            }
        }
    }
}