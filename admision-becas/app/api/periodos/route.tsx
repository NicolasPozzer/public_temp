
const urlback = "urlback";


export async function GET(){
	const response = await fetch(´${urlback}/periodos´, {
		method: "GET",
		headers: {},
	})

	if(!response.ok){
		console.log("Error a traer periodos");
	}

	const data_response = await response.json();

	return NextResponse.json(data_response)
}

export async function POST(req: Request){
	const data_req = await req.json();

	const response = await fetch(´${urlback}/periodos´, {
		method: "POST",
		headers: {},
		body: JSON.stringify(data_req)
	})

	if(!response.ok){
		console.log("Error al crear periodo")
	}

	const response_data = await response.json();

	return NextResponse.json(response_data);
}