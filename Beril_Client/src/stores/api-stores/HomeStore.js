import { writable } from "svelte/store";
export const HomeStore = writable()

export const loadData = async () => {
  const res = await fetch("http://localhost:5000/api/home")
  const data = await res.text()

    HomeStore.set(data.concat().toString())
}
loadData()

// Use this to make a persistante storage
// const store = writable(localStorage.getItem("store") || "");
//store.subscribe(val => localStorage.setItem("store", val));

// Use/check {browser} for svelte kit to prevent ssr error when tryring to use localstorage on server
