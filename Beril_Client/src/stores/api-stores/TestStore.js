import {writable} from "svelte/store";
// import { browser } from "$app/env";


// Use browser for local storage to avoid error on first load
// export const Count = writable(browser && (parseInt(localStorage.getItem("Count")) || 0));
// Count.subscribe(
// (val)=> browser && localStorage.setItem("Count", val.toString())
// )

export const Count = writable(0);
