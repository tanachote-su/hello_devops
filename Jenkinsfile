pipeline{
    agent any
	environment {
        DOCKERHUB_CREDENTIALS=credentials('dockerhub')
        def repoName = "icyberx"
        def imageTag = "1.0.0.2"
        def imageName = "hello_devops"
	}    
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

		stage('Deploying App to Kubernetes') {
		    steps {
			    sh "pwd"
			    sh "cat ./hello_devops/manifest/deployments.yaml"
		    }
		}
    }

}