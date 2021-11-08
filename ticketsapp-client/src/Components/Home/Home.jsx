import React from 'react';
import './Home.css';

class Home extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            error: null,
            isLoaded: false,
            items: []
        }
    }

    componentDidMount() {
        fetch("http://localhost:5000/api/ticket")
        .then(res => res.json())
        .then(
            (result) => {
                console.log(result);
                this.setState({
                    isLoaded: true,
                    items: result
                });
            },
            (error) => {
                this.setState({
                    isLoaded: true,
                    error
                });
            }
        )
    }
    
    render() {
        const { error, isLoaded, items } = this.state;

        return (
            <table>
                <thead>
                    <tr>
                        <td>
                            Name
                        </td>
                    </tr>
                </thead>
                <tbody>
                {items.map(item => (
                    <tr key={item.id}>
                        <td>
                            {item.name}
                        </td>
                    </tr>
                ))}
                </tbody>
            </table>
        );
    }
}

export default Home;
