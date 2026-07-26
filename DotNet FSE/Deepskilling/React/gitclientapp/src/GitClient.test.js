import GitClient from "./GitClient";
import axios from "axios";

jest.mock("axios");

describe("Git Client Tests", () => {

    test("should return repository names for techiesyed", async () => {

        const mockData = [
            { id: 1, name: "RepoOne" },
            { id: 2, name: "RepoTwo" },
            { id: 3, name: "RepoThree" }
        ];

        axios.get.mockResolvedValue({
            data: mockData
        });

        const result = await GitClient.getRepositories("techiesyed");

        expect(result).toEqual(mockData);

        expect(axios.get).toHaveBeenCalledWith(
            "https://api.github.com/users/techiesyed/repos"
        );

    });

});