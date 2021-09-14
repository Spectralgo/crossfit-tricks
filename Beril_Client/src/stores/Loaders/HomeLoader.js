/**
 * @type {import('@sveltejs/kit').Load}
 */


export async function LoadHome({ page, fetch, session, context }) {
  const homeApiUrl = "http://localhost:5000/api/home";
  const homeApiResponse = await fetch(homeApiUrl);

  if (homeApiResponse.ok) {
    return {
      props: {
    HomeApi: {
      IndexResponse: await homeApiResponse.text()
    } 
        
      }
    };
  }

  return {
    status: homeApiResponse.status,
    error: new Error(`Could not load ${homeApiUrl}`)
  };
}
