document.addEventListener('DOMContentLoaded', function ()
{
    document.querySelector('button').addEventListener('click', main);      
	$(document).on('click','input[type=text]',function(){ this.select(); });
	$("#master").select();
});

function main()
{
	var master = $("#master").prop("value");
	var plaintext = $("#plaintext").prop("value");
	var result = Tea.encrypt(plaintext, master);
	$("#encrypted").prop( "value", result );
	$('input[type=text]').select();
};