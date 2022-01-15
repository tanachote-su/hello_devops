
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
                git credentialsId: 'github-key', url: 'https://github.com/tanachote-su/NETCore-CICD-pipeline-Example.git'
            }
        }
    }
}