class Calculator {
	
	add(a, b)
	{
		return a + b;
	}
	minus(a, b)
	{
		return a - b;
	}	
}

describe('calculator', function() {
	
	var c = new Calculator();
	it('add numbers', function()
	{
		console.log('Adding 2 numbers! ' + c.add(2, 5));
		expect(c.add(2,5)).toBe(7);
	});
	it('add numbers', function()
	{
		console.log('Adding 2 numbers!')
	});	
});

class GetAjax 
{
    // npm install xmlhttprequest
    go(done) {
        var XMLHttpRequest = require("xmlhttprequest").XMLHttpRequest;
        let req = new XMLHttpRequest();
        //let url = `https://jsonplaceholder.typicode.com/posts`
        let url = `http://localhost:62492/api/calculator/add/3/4`
        
        req.open('GET', url, false)
        console.log('hi')
        req.onload = () => {
            console.log('Completed..........')
            console.log(req.response)
            if (req.status != 200)
            {
                //console.log(resp)
                return
            }
        }
        req.onerror = function () {
            alert('error')
        }
        
        req.send(null)
        
        console.log(req.responseText)
        console.log(JSON.parse(req.responseText).SUM)
    }
}
describe('calculator', function() {
    it('add numbers', function()
	{
        var aj = new GetAjax()
        aj.go()
    });	
    
});

