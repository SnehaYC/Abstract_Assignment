let FeedbackArray= [];

        function addFeekback(){
            let Feedback=document.getElementById("inputlg");

            if(Feedback.value.trim() !== ""){
                FeedbackArray.push(Feedback.value.trim());
            }

            Feedback.value= "";
            let textBox=document.getElementById("text-box");
            textBox.value=FeedbackArray.join("\n");
        }