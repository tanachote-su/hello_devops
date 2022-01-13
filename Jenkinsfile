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
        stage("Build Docker Image"){
            steps{
                dir('hello_devops') {
                    echo "Clean Environment ..."
                    sh "docker rm -f ${imageName}"
                    sh "docker rmi -f ${repoName}/${imageName}:${imageTag}"
                    echo ""
                    echo "Build image && Run container in background ..."
                    sh "docker build -f ./hello_devops/Dockerfile -t ${repoName}/${imageName}:${imageTag} ."
                }
            }
        }
		stage('Login') {

			steps {
				sh 'echo $DOCKERHUB_CREDENTIALS_PSW | docker login -u $DOCKERHUB_CREDENTIALS_USR --password-stdin'
			}
		}

		stage('Push') {

			steps {
				sh 'docker push ${repoName}/${imageName}:${imageTag}'
			}
		}


        stage('Deploying App to Kubernetes') {
            steps{
                dir('hello_devops/manifest/') {
                    sh "pwd"
                    sh "cat deployment.yaml"
                }
            }  
        }
    }
	post {
		always {
			sh 'docker logout'
		}
	}    
}